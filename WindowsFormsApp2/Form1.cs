using MetroFramework.Forms;
using Transitions;

namespace WindowsFormsApp2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            // Тук задаваме начална точка, на нашите елементи, за да можем да ги анимираме.
            // Анимацията работи така: От тази точка, отиваш на точка A по X или Y.
            // Например: Ако укажем Left или Right, ние ще анимираме по X.
            // И обратно, ако зададем Top или Bottom, ние ще анимираме по Y.
            // 
            // Най-лесно как се прави: Задава се начална точка на X или Y на елемента,
            // на който искаме да направим анимация, която е равна на ширината или височината
            // на формата. Ако имам една форма 400 ширина на 600 височина и искам да анимирам по X,
            // то тогава ще ми трябва текущата точка, където се намира контролът. Ако е на 231 X и 48 Y,
            // нещата ще изглеждат така:
            //
            // this.metroPanel1.Location = new System.Drawing.Point(400, 48);
            //
            // Тук запазваме Y, защото искаме само по X да анимираме. Този тип анимация е отдясно наляво.
            // Ако искаме отляво надясно, тогава ще трябва да зададем координати от сорта на:

            // 0(началната точка на формата спрямо координатната система) - ширината на контролата. Например:
            // Ако ширината на панела ми е 200, тогава би изглеждало така:
            //
            // this.metroPanel1.Location = new System.Drawing.Point(-200, 48);
            //

            this.metroPanel1.Location = new System.Drawing.Point(787, 63);
            this.metroPanel2.Location = new System.Drawing.Point(23, 450);

            // Това тук в скобите на new Transition е типа анимация
            // В скобите на new TransitionType_<Вида на анимацията> е времето, което ще отнеме
            // да се изпълни дадената анимация
            var iTransition_Ease = new Transition(new TransitionType_EaseInEaseOut(2000));
            var iTransition_Accel = new Transition(new TransitionType_Acceleration(2000));

            // Добавяме елемент, който да анимираме. Ако искаме да имаме различни видове анимации
            // ще си добавим нов вид анимация(transition).
            iTransition_Ease.add(this.metroPanel1, "Left", 23);
            iTransition_Accel.add(this.metroPanel2, "Top", 241);

            // Това изпълнява всичките добавени анимации от по-горе. Е хубу де :D няма да е тая анимацията
            iTransition_Ease.run();
            iTransition_Accel.run();
        }
    }
}
