using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class WindowProgramm
{
    static void Main(string[] args)
    {
        double R1, R2, S1, S2, S3;
        MessageBox.Show("Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2.", "Решить задачу", MessageBoxButtons.OK, MessageBoxIcon.Information);
        R1 = double.Parse(Interaction.InputBox("Введите значение R1:"));
        R2 = double.Parse(Interaction.InputBox("Введите значение R2:"));
        S1 = Math.PI * Math.Pow(R1, 2);
        S2 = Math.PI * Math.Pow(R2, 2);
        S3 = S1 - S2;
        MessageBox.Show($"Площади кругов: S1 = {S1,5:#0.##}, S2 = {S2,5:#0.##}; Площадь кольца, внешний радиус которого = R1, а внутренний = R2: S3 = {S3,5:#0.##}.", "Ответ на задачу", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
}