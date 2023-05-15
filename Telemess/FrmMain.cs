using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using YANF.Script;
using static Microsoft.VisualBasic.Interaction;
using static System.Drawing.Color;
using static System.Drawing.Region;
using static System.Threading.Tasks.Task;
using static System.Windows.Forms.Application;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static Telemess.Properties.Resources;
using static Telemess.Properties.Settings;
using static YANF.Script.YANConstant.MsgBoxLang;
using static YANF.Script.YANDisplay;
using static YANF.Script.YANEvent;

namespace Telemess;

public partial class FrmMain : Form
{
    #region Fields
    private TelegramBotClient _botClient;
    #endregion

    #region Constructors
    public FrmMain()
    {
        InitializeComponent();
        pnlBar.MouseDown += MoveFrm_MouseDown;
        pnlBar.MouseMove += MoveFrm_MouseMove;
        pnlBar.MouseUp += MoveFrm_MouseUp;
        Region = FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
    }
    #endregion

    #region Events
    // Shown form event
    private async void FrmMain_Shown(object sender, EventArgs e)
    {
        lblCl.Select();
        this.FadeIn();
        await BotRequired();
    }

    // Closing form event
    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) => this.FadeOut();

    // Close control mouse enter event
    private void LblCl_MouseEnter(object sender, EventArgs e)
    {
        lblCl.ForeColor = White;
        lblCl.BackColor = FromArgb(233, 37, 57);
    }

    // Close control mouse leave event
    private void LblCl_MouseLeave(object sender, EventArgs e) => DefaultFontButton(lblCl);

    // Close control click event
    private void LblCl_Click(object sender, EventArgs e) => Close();

    // Add control mouse enter event
    private void LblAdd_MouseEnter(object sender, EventArgs e)
    {
        lblAdd.ForeColor = White;
        lblAdd.BackColor = FromArgb(37, 48, 62);
    }

    // Add control mouse leave event
    private void LblAdd_MouseLeave(object sender, EventArgs e) => DefaultFontButton(lblAdd);

    // Add control click event
    private async void LblAdd_Click(object sender, EventArgs e)
    {
        Default.Api_Token = string.Empty;
        Default.Chat_Id = string.Empty;
        Default.Save();
        await BotRequired();
    }

    // Sender control key down event
    private async void TxtSndr_KeyDown(object sender, KeyEventArgs e)
    {
        var msg = txtSndr.String;

        if (e.KeyCode is Keys.Enter && !string.IsNullOrWhiteSpace(msg))
        {
            rtxRx.Text += $" You: {msg}\n";
            ScrollToEndRtxRx();
            txtSndr.PlaceholderText = string.Empty;
            txtSndr.String = string.Empty;
            await SendMessage(msg);
        }
    }

    // Sender control leave event
    private void TxtSndr_Leave(object sender, EventArgs e) => txtSndr.PlaceholderText = placeholder_text;
    #endregion

    #region Methods
    // Default font button
    private void DefaultFontButton(Label button)
    {
        button.ForeColor = DarkGray;
        button.BackColor = FromArgb(31, 41, 54);
    }

    // Scroll to end rich text box receiver
    private void ScrollToEndRtxRx()
    {
        rtxRx.SelectionStart = rtxRx.Text.Length;
        rtxRx.ScrollToCaret();
    }

    // Required of bot
    private async Task BotRequired()
    {
        if (string.IsNullOrWhiteSpace(Default.Api_Token))
        {
        SgdUpChkPt:
            var token = InputBox("Nhập vào API Token của Telegram", "Token", null, -1, -1);

            if (string.IsNullOrWhiteSpace(token))
            {
                if (YANMessageBox.Show("LỖI", "API Token không được để trống!", RetryCancel, Error, VIE) == Retry)
                {
                    goto SgdUpChkPt;
                }
                else
                {
                    Exit();
                    return;
                }
            }
            else
            {
                Default.Api_Token = token;
                Default.Save();
            }
        }

        if (string.IsNullOrWhiteSpace(Default.Chat_Id))
        {
        VerChkPt:
            var id = InputBox("Nhập vào Chat ID của Telegram", "ID", null, -1, -1);

            if (string.IsNullOrWhiteSpace(id))
            {
                if (YANMessageBox.Show("LỖI", "ID không được để trống!", RetryCancel, Error, VIE) == Retry)
                {
                    goto VerChkPt;
                }
                else
                {
                    Exit();
                    return;
                }
            }
            else
            {
                Default.Chat_Id = id;
                Default.Save();
            }
        }

        if (_botClient is not null)
        {
            Restart();
        }

        _botClient = new TelegramBotClient(Default.Api_Token);
        await StartBot();
    }

    // Start bot
    private async Task StartBot()
    {
        var token = new CancellationTokenSource();
        var cancelToken = token.Token;
        var reOpt = new ReceiverOptions
        {
            AllowedUpdates = { }
        };
        await _botClient.ReceiveAsync(ReceiveMessage, ErrorMessage, reOpt, cancelToken);
    }

    // Receive message
    private Task ReceiveMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Message is not null && update.Type is UpdateType.Message && update.Message.Type is MessageType.Text)
        {
            var messageText = $" Bot: {update.Message.Text}\n";
            _ = rtxRx.Invoke((MethodInvoker)delegate
            {
                rtxRx.Text += messageText;
                ScrollToEndRtxRx();
            });
        }
        return CompletedTask;
    }

    // Error message
    private Task ErrorMessage(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is ApiRequestException)
        {
            var errorMessage = $" Error: {exception.Message}\n";
            _ = rtxRx.Invoke((MethodInvoker)delegate
            {
                rtxRx.Text += errorMessage;
                ScrollToEndRtxRx();
            });
        }
        return CompletedTask;
    }

    // Send message
    private async Task SendMessage(string message) => await _botClient.SendTextMessageAsync(Default.Chat_Id, message);
    #endregion
}
