using DemoLambdaObjects.Classes;

namespace DemoLambdaObjects
{
    public partial class FormLambda : Form
    {
        public FormLambda()
        {
            InitializeComponent();
        }

        private void buttonLambda_Click(object sender, EventArgs e)
        {
            var personList = Repository.GetPersonList();



            //1. Ta fram en lista p� alla personer som har
            //mellan 39 och 45 i skor. Sortera listan p� skostorlek st�rsta f�rst

            //Type har flera properties s�  vi skriver type.Name

            var result_45 = personList
                .Where(p => p.ShoeSize >= 39 && p.ShoeSize <= 45
                        && p.Type.Name=="Vuxen")
                .OrderByDescending(p => p.ShoeSize)
                .ToList();






            //2.Ta fram en lista p� alla personer f�dda efter 1982. Sortera p� namn i bokstavsordning

            var result82 = personList
                .Where(p => p.BornDate.Year > 1982)
                .OrderBy(p => p.Name)
                .OrderByDescending(p => p.ShoeSize)
                .ToList();


            //3.Tar fram st�rsta skostorleken i listan
            //Dels v�rdet och visa �ven hur man tar hela objectet 


            int maxShoeSize = personList.Max(p => p.ShoeSize);


           //  when we use First instead of ToList


            var personMaxShoeSize = personList
                                    .OrderByDescending(p => p.ShoeSize)
                                    .First();


            //4.Ta fram de 3 �ldsta personerna i listan
            //vi sorterar listan op datum med minsta datumen f�rst . sedan tar vi 
            // 3 f�rsta rader
            var oldest = personList
                                    .OrderBy(p => p.BornDate)
                                    .Take(3)
                                    .ToList();



        }
    }
}
