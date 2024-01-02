using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramenta
{
    class FormRoundedCorners
    {
        public static object Black { get; private set; }

        // importação de funções da API do windons para criar arredondadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottmRect, int nWidthEllipse, int nHeightEllipse);

        public static void ApplyRoundedCorners(Form form, int borderRadius)
        {
            if (form == null)
            {
                throw new ArgumentNullException("O formulario não pode ser nulo.");
            }
            IntPtr handle = form.Handle;

            //crie uma região com bordas arredondadas
            Region region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, borderRadius, borderRadius));
            // Atribua a região ao formulário
            form.Region = region;
        }
        public static void ApplyPerfectDrawing(Form form)
        {
            if (form == null)
            {
                throw new ArgumentNullException("O formulario não pode ser nulo.");

            }
            form.Paint += (sender, e) =>
            {
                // crie um desenho com anti-aliasing para obter uma aparencia suave
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                int borderRadius = 20;
                Rectangle rect = new Rectangle(10, 10, form.Width + 20, form.Height + 20);
                //e.Graphics.FillRoundRectangle(Brushes, rect, borderRadius);
                //e.Graphics.FillRoundRectangle(Pens, Black, , rect, borderRadius);
            };
        }
    }
}
