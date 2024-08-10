
namespace WCFConsuming
{
  partial class WCFTestForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnExecute = new System.Windows.Forms.Button();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.lblResponseMsg = new System.Windows.Forms.Label();
      this.btnCustomer = new System.Windows.Forms.Button();
      this.rchResponse = new System.Windows.Forms.RichTextBox();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtJson = new System.Windows.Forms.TextBox();
      this.lblResponseUpdate = new System.Windows.Forms.Label();
      this.lblTitle1 = new System.Windows.Forms.Label();
      this.lblTitle2 = new System.Windows.Forms.Label();
      this.btnToken = new System.Windows.Forms.Button();
      this.rchToken = new System.Windows.Forms.RichTextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(716, 92);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(97, 39);
      this.btnExecute.TabIndex = 0;
      this.btnExecute.Text = "Run";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // txtMessage
      // 
      this.txtMessage.Location = new System.Drawing.Point(94, 92);
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Size = new System.Drawing.Size(600, 31);
      this.txtMessage.TabIndex = 1;
      // 
      // lblResponseMsg
      // 
      this.lblResponseMsg.AutoSize = true;
      this.lblResponseMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResponseMsg.Location = new System.Drawing.Point(88, 155);
      this.lblResponseMsg.Name = "lblResponseMsg";
      this.lblResponseMsg.Size = new System.Drawing.Size(76, 31);
      this.lblResponseMsg.TabIndex = 2;
      this.lblResponseMsg.Text = " Msg";
      // 
      // btnCustomer
      // 
      this.btnCustomer.Location = new System.Drawing.Point(1250, 92);
      this.btnCustomer.Name = "btnCustomer";
      this.btnCustomer.Size = new System.Drawing.Size(181, 39);
      this.btnCustomer.TabIndex = 3;
      this.btnCustomer.Text = "Get Customer";
      this.btnCustomer.UseVisualStyleBackColor = true;
      this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
      // 
      // rchResponse
      // 
      this.rchResponse.Location = new System.Drawing.Point(908, 155);
      this.rchResponse.Name = "rchResponse";
      this.rchResponse.Size = new System.Drawing.Size(783, 230);
      this.rchResponse.TabIndex = 4;
      this.rchResponse.Text = "";
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(94, 464);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(181, 39);
      this.btnUpdate.TabIndex = 5;
      this.btnUpdate.Text = "Update Customer";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // txtJson
      // 
      this.txtJson.Location = new System.Drawing.Point(94, 204);
      this.txtJson.Multiline = true;
      this.txtJson.Name = "txtJson";
      this.txtJson.Size = new System.Drawing.Size(719, 230);
      this.txtJson.TabIndex = 6;
      // 
      // lblResponseUpdate
      // 
      this.lblResponseUpdate.AutoSize = true;
      this.lblResponseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResponseUpdate.Location = new System.Drawing.Point(305, 464);
      this.lblResponseUpdate.Name = "lblResponseUpdate";
      this.lblResponseUpdate.Size = new System.Drawing.Size(82, 31);
      this.lblResponseUpdate.TabIndex = 7;
      this.lblResponseUpdate.Text = "Resp";
      // 
      // lblTitle1
      // 
      this.lblTitle1.AutoSize = true;
      this.lblTitle1.Location = new System.Drawing.Point(89, 29);
      this.lblTitle1.Name = "lblTitle1";
      this.lblTitle1.Size = new System.Drawing.Size(83, 25);
      this.lblTitle1.TabIndex = 8;
      this.lblTitle1.Text = "Playing";
      // 
      // lblTitle2
      // 
      this.lblTitle2.AutoSize = true;
      this.lblTitle2.Location = new System.Drawing.Point(89, 576);
      this.lblTitle2.Name = "lblTitle2";
      this.lblTitle2.Size = new System.Drawing.Size(147, 25);
      this.lblTitle2.TabIndex = 9;
      this.lblTitle2.Text = "Getting Token";
      // 
      // btnToken
      // 
      this.btnToken.Location = new System.Drawing.Point(94, 644);
      this.btnToken.Name = "btnToken";
      this.btnToken.Size = new System.Drawing.Size(181, 39);
      this.btnToken.TabIndex = 10;
      this.btnToken.Text = "Get Token";
      this.btnToken.UseVisualStyleBackColor = true;
      this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
      // 
      // rchToken
      // 
      this.rchToken.Location = new System.Drawing.Point(335, 644);
      this.rchToken.Name = "rchToken";
      this.rchToken.Size = new System.Drawing.Size(1356, 188);
      this.rchToken.TabIndex = 11;
      this.rchToken.Text = "";
      // 
      // WCFTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1836, 863);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.rchToken);
      this.Controls.Add(this.btnToken);
      this.Controls.Add(this.lblTitle2);
      this.Controls.Add(this.lblTitle1);
      this.Controls.Add(this.lblResponseUpdate);
      this.Controls.Add(this.txtJson);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.rchResponse);
      this.Controls.Add(this.btnCustomer);
      this.Controls.Add(this.lblResponseMsg);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.btnExecute);
      this.Name = "WCFTestForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Label lblResponseMsg;
    private System.Windows.Forms.Button btnCustomer;
    private System.Windows.Forms.RichTextBox rchResponse;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtJson;
    private System.Windows.Forms.Label lblResponseUpdate;
    private System.Windows.Forms.Label lblTitle1;
    private System.Windows.Forms.Label lblTitle2;
    private System.Windows.Forms.Button btnToken;
    private System.Windows.Forms.RichTextBox rchToken;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
  }
}

