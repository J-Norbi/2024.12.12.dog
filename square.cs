using System.Windows.Forms;

namespace _2024._12._12.gyakorlas
{
    internal class square : UserControl
    {
        private CheckBox checkBox1;
        public square()         // ez a konstructora a classnak
        {
            InitializeComponent();
            checkBox1.CheckedChanged += (s, e) =>
            {
                IsChecked = checkBox1.Checked;
            };
        }
        public bool IsChecked { get; private set; }     //  az egész bool publikus, kivéve a set
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            this.Controls.Add(this.checkBox1);
            this.Name = "square";
            this.Size = new System.Drawing.Size(82, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
