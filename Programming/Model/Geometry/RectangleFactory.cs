using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит методы для создания прямоугольников со случайными значениями.
    /// </summary>
    static class RectangleFactory
    {
        static Random random = new Random();
        static Colour colour;
        static string _rectColour;

        /// <summary>
        /// Создает экземпляр прямоугольника со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Rectangle Randomize()
        {
            //Получаем случайные значения длины и ширины.
            int recLength = random.Next(20, 200);
            int recWide = random.Next(20, 200);

            //Присваиваем случайное значение цвета из перечисления Colour.
            int randomIndex = ChooseRandomEnumIndex(colour);
            colour = (Colour)randomIndex;
            _rectColour = colour.ToString();

            Rectangle rect = new Rectangle(recWide, recLength, Colour.Green);
            return rect;
        }

        /// <summary>
        /// Создает панель, которая соответствует параметрам переданного прямоугольника.
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Panel PanelFactory(Rectangle rect)
        {
            Panel newPanel = new Panel();
            newPanel.Size = new Size(rect.Width, rect.Length);
            newPanel.Location = new Point(rect.Center.coord_X, rect.Center.coord_Y);
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            return newPanel;
        }

        /// <summary>
        /// Выбирает случайный индекс из переданного перечисления.
        /// </summary>
        /// <param name="myEnum"></param>
        /// <returns></returns>
        public static int ChooseRandomEnumIndex(Enum myEnum)
        {
            Random rand = new Random();
            Array values = Enum.GetValues(myEnum.GetType());
            return rand.Next(0, values.Length);
        }
    }
}
