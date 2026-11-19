namespace MDI_Editor
{
    public partial class Form1 : Form
    {
        private int formindex = 0;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formindex = this.MdiChildren.Length;

            Form ChildForm = new Form();

            ChildForm.Name = "Child" + (formindex + 1).ToString();
            ChildForm.Text = "Child" + (formindex + 1).ToString();
            ChildForm.MdiParent = this;

            TextBox txtBox = new TextBox();
            txtBox.Dock = DockStyle.Fill;
            txtBox.Multiline = true;
            txtBox.ScrollBars = ScrollBars.Both;

            ChildForm.Controls.Add(txtBox);
            ChildForm.Show();
        }
            private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

    }

}
