using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class WindowTask
{
    static void Main(string[] args)
    {
        double V1, V2, S, T, CommonPath, DistanceBetweenCarsInTHours;
        MessageBox.Show("Скорость первого автомобиля V1 км/ч, второго - V2 км/ч, расстояние между ними S км. Определить расстояние между ними через T часов, если автомобили первоначально движутся навстречу друг другу", "Решить задачу", MessageBoxButtons.OK, MessageBoxIcon.Question);
        V1 = double.Parse(Interaction.InputBox("Введите скорость первого автомобиля (V1) км/ч:", "Ввод данных"));
        V2 = double.Parse(Interaction.InputBox("Введите скорость второго автомобиля (V2) км/ч:", "Ввод данных"));
        S = double.Parse(Interaction.InputBox("Введите стартовое расстояние между автомобилями (S) км:", "Ввод данных"));
        T = double.Parse(Interaction.InputBox("Укажите время, в течение которого автомобили двигались навстречу друг другу (T) часов:", "Ввод данных"));
        CommonPath = T * (V1 + V2);
        DistanceBetweenCarsInTHours = Math.Abs(S - CommonPath);
        MessageBox.Show($"Расстояние между автомобилями через T часов = {DistanceBetweenCarsInTHours} км.", "Ответ на задачу", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}