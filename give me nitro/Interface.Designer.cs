
namespace give_me_nitro
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.EnterDNlink_label = new System.Windows.Forms.Label();
            this.Payment_txt_box = new System.Windows.Forms.TextBox();
            this.Send_bnt = new System.Windows.Forms.Button();
            this.linkerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterDNlink_label
            // 
            this.EnterDNlink_label.AutoSize = true;
            this.EnterDNlink_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterDNlink_label.ForeColor = System.Drawing.Color.White;
            this.EnterDNlink_label.Location = new System.Drawing.Point(10, 9);
            this.EnterDNlink_label.Name = "EnterDNlink_label";
            this.EnterDNlink_label.Size = new System.Drawing.Size(298, 37);
            this.EnterDNlink_label.TabIndex = 2;
            this.EnterDNlink_label.Text = "Enter Discord Nitro link:";
            // 
            // Payment_txt_box
            // 
            this.Payment_txt_box.Location = new System.Drawing.Point(10, 189);
            this.Payment_txt_box.Name = "Payment_txt_box";
            this.Payment_txt_box.PlaceholderText = "E.g : http://discord.gift/example";
            this.Payment_txt_box.Size = new System.Drawing.Size(217, 23);
            this.Payment_txt_box.TabIndex = 4;
            this.Payment_txt_box.Text = "E.g : http://discord.gift/example";
            // 
            // Send_bnt
            // 
            this.Send_bnt.Location = new System.Drawing.Point(233, 189);
            this.Send_bnt.Name = "Send_bnt";
            this.Send_bnt.Size = new System.Drawing.Size(75, 23);
            this.Send_bnt.TabIndex = 6;
            this.Send_bnt.Text = "Send";
            this.Send_bnt.UseVisualStyleBackColor = true;
            this.Send_bnt.Click += new System.EventHandler(this.Send_bnt_Click);
            // 
            // linkerror
            // 
            this.linkerror.AutoSize = true;
            this.linkerror.ForeColor = System.Drawing.Color.Red;
            this.linkerror.Location = new System.Drawing.Point(12, 215);
            this.linkerror.Name = "linkerror";
            this.linkerror.Size = new System.Drawing.Size(225, 15);
            this.linkerror.TabIndex = 7;
            this.linkerror.Text = "Please make sure you entered a valid link.";
            this.linkerror.Visible = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(320, 384);
            this.ControlBox = false;
            this.Controls.Add(this.linkerror);
            this.Controls.Add(this.Send_bnt);
            this.Controls.Add(this.Payment_txt_box);
            this.Controls.Add(this.EnterDNlink_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Interface_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EnterDNlink_label;
        private System.Windows.Forms.TextBox Payment_txt_box;
        private System.Windows.Forms.Button Send_bnt;
        private System.Windows.Forms.Label linkerror;
    }
}

