namespace Компьютерная_графика2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растроваяГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.векторнаяГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовыеМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практическиеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimpПрактическаяРабота1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimpПрактическаяРабота2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkscapeПрактическаяРабота1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkscapeПрактическаяРабота2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самостоятельныеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.векторныйРедакторInkscapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаВAdobePhotoshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растровыйРедакторGIMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.тест1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тест2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лекцииToolStripMenuItem,
            this.практическиеРаботыToolStripMenuItem,
            this.самостоятельныеРаботыToolStripMenuItem,
            this.тестыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лекцииToolStripMenuItem
            // 
            this.лекцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem,
            this.растроваяГрафикаToolStripMenuItem,
            this.векторнаяГрафикаToolStripMenuItem,
            this.цветовыеМоделиToolStripMenuItem});
            this.лекцииToolStripMenuItem.Name = "лекцииToolStripMenuItem";
            this.лекцииToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.лекцииToolStripMenuItem.Text = "Лекции";
            // 
            // введениеВКомпьютернуюГрафикуToolStripMenuItem
            // 
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem.Name = "введениеВКомпьютернуюГрафикуToolStripMenuItem";
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem.Text = "Введение в компьютерную графику";
            this.введениеВКомпьютернуюГрафикуToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // растроваяГрафикаToolStripMenuItem
            // 
            this.растроваяГрафикаToolStripMenuItem.Name = "растроваяГрафикаToolStripMenuItem";
            this.растроваяГрафикаToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.растроваяГрафикаToolStripMenuItem.Text = "Растровая графика";
            this.растроваяГрафикаToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // векторнаяГрафикаToolStripMenuItem
            // 
            this.векторнаяГрафикаToolStripMenuItem.Name = "векторнаяГрафикаToolStripMenuItem";
            this.векторнаяГрафикаToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.векторнаяГрафикаToolStripMenuItem.Text = "Векторная графика";
            this.векторнаяГрафикаToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // цветовыеМоделиToolStripMenuItem
            // 
            this.цветовыеМоделиToolStripMenuItem.Name = "цветовыеМоделиToolStripMenuItem";
            this.цветовыеМоделиToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.цветовыеМоделиToolStripMenuItem.Text = "Цветовые модели";
            this.цветовыеМоделиToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // практическиеРаботыToolStripMenuItem
            // 
            this.практическиеРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gimpПрактическаяРабота1ToolStripMenuItem,
            this.gimpПрактическаяРабота2ToolStripMenuItem,
            this.inkscapeПрактическаяРабота1ToolStripMenuItem,
            this.inkscapeПрактическаяРабота2ToolStripMenuItem});
            this.практическиеРаботыToolStripMenuItem.Name = "практическиеРаботыToolStripMenuItem";
            this.практическиеРаботыToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.практическиеРаботыToolStripMenuItem.Text = "Практические работы";
            // 
            // gimpПрактическаяРабота1ToolStripMenuItem
            // 
            this.gimpПрактическаяРабота1ToolStripMenuItem.Name = "gimpПрактическаяРабота1ToolStripMenuItem";
            this.gimpПрактическаяРабота1ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.gimpПрактическаяРабота1ToolStripMenuItem.Text = "Gimp. Практическая работа №1";
            this.gimpПрактическаяРабота1ToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // gimpПрактическаяРабота2ToolStripMenuItem
            // 
            this.gimpПрактическаяРабота2ToolStripMenuItem.Name = "gimpПрактическаяРабота2ToolStripMenuItem";
            this.gimpПрактическаяРабота2ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.gimpПрактическаяРабота2ToolStripMenuItem.Text = "Gimp. Практическая работа №2";
            this.gimpПрактическаяРабота2ToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // inkscapeПрактическаяРабота1ToolStripMenuItem
            // 
            this.inkscapeПрактическаяРабота1ToolStripMenuItem.Name = "inkscapeПрактическаяРабота1ToolStripMenuItem";
            this.inkscapeПрактическаяРабота1ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.inkscapeПрактическаяРабота1ToolStripMenuItem.Text = "Inkscape. Практическая работа №1";
            this.inkscapeПрактическаяРабота1ToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // inkscapeПрактическаяРабота2ToolStripMenuItem
            // 
            this.inkscapeПрактическаяРабота2ToolStripMenuItem.Name = "inkscapeПрактическаяРабота2ToolStripMenuItem";
            this.inkscapeПрактическаяРабота2ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.inkscapeПрактическаяРабота2ToolStripMenuItem.Text = "Inkscape. Практическая работа №2";
            this.inkscapeПрактическаяРабота2ToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // самостоятельныеРаботыToolStripMenuItem
            // 
            this.самостоятельныеРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.векторныйРедакторInkscapeToolStripMenuItem,
            this.работаВAdobePhotoshopToolStripMenuItem,
            this.растровыйРедакторGIMPToolStripMenuItem});
            this.самостоятельныеРаботыToolStripMenuItem.Name = "самостоятельныеРаботыToolStripMenuItem";
            this.самостоятельныеРаботыToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.самостоятельныеРаботыToolStripMenuItem.Text = "Самостоятельные работы";
            // 
            // векторныйРедакторInkscapeToolStripMenuItem
            // 
            this.векторныйРедакторInkscapeToolStripMenuItem.Name = "векторныйРедакторInkscapeToolStripMenuItem";
            this.векторныйРедакторInkscapeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.векторныйРедакторInkscapeToolStripMenuItem.Text = "Векторный редактор Inkscape";
            this.векторныйРедакторInkscapeToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // работаВAdobePhotoshopToolStripMenuItem
            // 
            this.работаВAdobePhotoshopToolStripMenuItem.Name = "работаВAdobePhotoshopToolStripMenuItem";
            this.работаВAdobePhotoshopToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.работаВAdobePhotoshopToolStripMenuItem.Text = "Работа в Adobe Photoshop";
            this.работаВAdobePhotoshopToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // растровыйРедакторGIMPToolStripMenuItem
            // 
            this.растровыйРедакторGIMPToolStripMenuItem.Name = "растровыйРедакторGIMPToolStripMenuItem";
            this.растровыйРедакторGIMPToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.растровыйРедакторGIMPToolStripMenuItem.Text = "Растровый редактор GIMP";
            this.растровыйРедакторGIMPToolStripMenuItem.Click += new System.EventHandler(this.openPdfToolStripClick);
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тест1ToolStripMenuItem,
            this.тест2ToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 27);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(800, 423);
            this.axAcroPDF1.TabIndex = 3;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(710, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 27);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Развернуть");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(758, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 27);
            this.button2.TabIndex = 5;
            this.toolTip2.SetToolTip(this.button2, "Назад");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(662, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 27);
            this.button3.TabIndex = 6;
            this.toolTip3.SetToolTip(this.button3, "Свернуть");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // тест1ToolStripMenuItem
            // 
            this.тест1ToolStripMenuItem.Name = "тест1ToolStripMenuItem";
            this.тест1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тест1ToolStripMenuItem.Text = "Тест №1";
            this.тест1ToolStripMenuItem.Click += new System.EventHandler(this.тест1ToolStripMenuItem_Click);
            // 
            // тест2ToolStripMenuItem
            // 
            this.тест2ToolStripMenuItem.Name = "тест2ToolStripMenuItem";
            this.тест2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тест2ToolStripMenuItem.Text = "Тест №2";
            this.тест2ToolStripMenuItem.Click += new System.EventHandler(this.тест2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Обучение компьютерной графики";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem лекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem введениеВКомпьютернуюГрафикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растроваяГрафикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem векторнаяГрафикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовыеМоделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практическиеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gimpПрактическаяРабота1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gimpПрактическаяРабота2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inkscapeПрактическаяРабота1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inkscapeПрактическаяРабота2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самостоятельныеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem векторныйРедакторInkscapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаВAdobePhotoshopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растровыйРедакторGIMPToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FormWindowState prevState;
        private System.Windows.Forms.ToolStripMenuItem тест1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тест2ToolStripMenuItem;
    }
}