using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyQuiz2
{
  public partial class Cheat : Form
  {
    public Cheat()
    {
      InitializeComponent();
    }

    private void Cheat_Load(object sender, EventArgs e)
    {
      lblCheatAnswer.Text = Tag.ToString();
    }

    private void btnLazy_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
