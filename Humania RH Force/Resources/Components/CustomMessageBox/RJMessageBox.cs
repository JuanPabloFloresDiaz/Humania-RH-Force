using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Humania_RH_Force.Resources.Components.CustomMessageBox
{
    public abstract class RJMessageBox
    {
        /// <summary>
        /// Muestra una ventana de mensaje con el texto especificado.
        /// </summary>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text))
                result = msgForm.ShowDialog();
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el texto y título especificados.
        /// </summary>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el texto, título y botones especificados.
        /// </summary>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el texto, título, botones e ícono especificados.
        /// </summary>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <param name="icon">Un valor de MessageBoxIcon que especifica el ícono que se mostrará en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el texto, título, botones, ícono y botón predeterminado especificados.
        /// </summary>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <param name="icon">Un valor de MessageBoxIcon que especifica el ícono que se mostrará en el cuadro de diálogo.</param>
        /// <param name="defaultButton">Un valor de MessageBoxDefaultButton que especifica cuál botón será el predeterminado.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el propietario y el texto especificados.
        /// </summary>
        /// <param name="owner">Una implementación de IWin32Window que representará al propietario del cuadro de diálogo.</param>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text))
                result = msgForm.ShowDialog(owner);
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el propietario, texto y título especificados.
        /// </summary>
        /// <param name="owner">Una implementación de IWin32Window que representará al propietario del cuadro de diálogo.</param>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el propietario, texto, título y botones especificados.
        /// </summary>
        /// <param name="owner">Una implementación de IWin32Window que representará al propietario del cuadro de diálogo.</param>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog(owner);
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el propietario, texto, título, botones e ícono especificados.
        /// </summary>
        /// <param name="owner">Una implementación de IWin32Window que representará al propietario del cuadro de diálogo.</param>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <param name="icon">Un valor de MessageBoxIcon que especifica el ícono que se mostrará en el cuadro de diálogo.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }

        /// <summary>
        /// Muestra una ventana de mensaje con el propietario, texto, título, botones, ícono y botón predeterminado especificados.
        /// </summary>
        /// <param name="owner">Una implementación de IWin32Window que representará al propietario del cuadro de diálogo.</param>
        /// <param name="text">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <param name="caption">El título del cuadro de diálogo.</param>
        /// <param name="buttons">Un valor de MessageBoxButtons que especifica los botones que se mostrarán en el cuadro de diálogo.</param>
        /// <param name="icon">Un valor de MessageBoxIcon que especifica el ícono que se mostrará en el cuadro de diálogo.</param>
        /// <param name="defaultButton">Un valor de MessageBoxDefaultButton que especifica cuál botón será el predeterminado.</param>
        /// <returns>Un valor de DialogResult que indica el resultado del cuadro de diálogo.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }
    }

}
