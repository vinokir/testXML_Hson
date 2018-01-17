namespace testXML_JSON
{
    partial class ConvertXMLtoJson_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.XML_textBox = new System.Windows.Forms.TextBox();
            this.JSON_textBox = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.labelXML = new System.Windows.Forms.Label();
            this.labelJSON = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XML_textBox
            // 
            this.XML_textBox.Location = new System.Drawing.Point(12, 34);
            this.XML_textBox.Multiline = true;
            this.XML_textBox.Name = "XML_textBox";
            this.XML_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.XML_textBox.Size = new System.Drawing.Size(296, 245);
            this.XML_textBox.TabIndex = 0;
            // 
            // JSON_textBox
            // 
            this.JSON_textBox.Location = new System.Drawing.Point(362, 34);
            this.JSON_textBox.Multiline = true;
            this.JSON_textBox.Name = "JSON_textBox";
            this.JSON_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JSON_textBox.Size = new System.Drawing.Size(296, 245);
            this.JSON_textBox.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(283, 302);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(107, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Конвертировать";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // labelXML
            // 
            this.labelXML.AutoSize = true;
            this.labelXML.Location = new System.Drawing.Point(9, 9);
            this.labelXML.Name = "labelXML";
            this.labelXML.Size = new System.Drawing.Size(29, 13);
            this.labelXML.TabIndex = 3;
            this.labelXML.Text = "XML";
            // 
            // labelJSON
            // 
            this.labelJSON.AutoSize = true;
            this.labelJSON.Location = new System.Drawing.Point(355, 9);
            this.labelJSON.Name = "labelJSON";
            this.labelJSON.Size = new System.Drawing.Size(35, 13);
            this.labelJSON.TabIndex = 4;
            this.labelJSON.Text = "JSON";
            // 
            // ConvertXMLtoJson_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 337);
            this.Controls.Add(this.labelJSON);
            this.Controls.Add(this.labelXML);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.JSON_textBox);
            this.Controls.Add(this.XML_textBox);
            this.Name = "ConvertXMLtoJson_Form";
            this.Text = "ConvertXMLtoJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XML_textBox;
        private System.Windows.Forms.TextBox JSON_textBox;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label labelXML;
        private System.Windows.Forms.Label labelJSON;
    }
}

