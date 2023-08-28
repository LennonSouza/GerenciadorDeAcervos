namespace GerenciadorDeAcervos.Personalizacao
{
    public class Personalisar
    {
        public static void CenterGroupBoxInPanel(Panel panel, GroupBox groupBox)
        {
            // Calcula a posição central horizontal e vertical no Panel
            int centerX = (panel.Width - groupBox.Width) / 2;
            int centerY = (panel.Height - groupBox.Height) / 2;

            // Define a posição do Label
            groupBox.Location = new Point(centerX, centerY);

            // Verifica se o Label está centralizado horizontalmente
            bool isCenteredHorizontally = Math.Abs(groupBox.Left - centerX) <= 1; // Tolerância de 1 pixel

            // Se não estiver centralizado, corrige a posição do Label
            if (!isCenteredHorizontally)
            {
                groupBox.Left = centerX;
            }

            // Verifica se o Label está centralizado verticalmente
            bool isCenteredVertically = Math.Abs(groupBox.Top - centerY) <= 1;

            // Se não estiver centralizado, corrige a posição do Label
            if (!isCenteredVertically)
            {
                groupBox.Top = centerY;
            }
        }

        public static void CenterLabelInPanel(Panel panel, Label label)
        {
            // Calcula a posição central horizontal e vertical no Panel
            int centerX = (panel.Width - label.Width) / 2;
            int centerY = (panel.Height - label.Height) / 2;

            // Define a posição do Label
            label.Location = new Point(centerX, centerY);

            // Verifica se o Label está centralizado horizontalmente
            bool isCenteredHorizontally = Math.Abs(label.Left - centerX) <= 1; // Tolerância de 1 pixel

            // Se não estiver centralizado, corrige a posição do Label
            if (!isCenteredHorizontally)
            {
                label.Left = centerX;
            }

            // Verifica se o Label está centralizado verticalmente
            bool isCenteredVertically = Math.Abs(label.Top - centerY) <= 1;

            // Se não estiver centralizado, corrige a posição do Label
            if (!isCenteredVertically)
            {
                label.Top = centerY;
            }
        }
    }
}
