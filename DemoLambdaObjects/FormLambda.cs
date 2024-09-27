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



            //1. Ta fram en lista på alla personer som har
            //mellan 39 och 45 i skor. Sortera listan på skostorlek största först

            //Type har flera properties så  vi skriver type.Name

            var result_45 = personList
                .Where(p => p.ShoeSize >= 39 && p.ShoeSize <= 45
                        && p.Type.Name=="Vuxen")
                .OrderByDescending(p => p.ShoeSize)
                .ToList();






            //2.Ta fram en lista på alla personer födda efter 1982. Sortera på namn i bokstavsordning

            var result82 = personList
                .Where(p => p.BornDate.Year > 1982)
                .OrderBy(p => p.Name)
                .OrderByDescending(p => p.ShoeSize)
                .ToList();


            //3.Tar fram största skostorleken i listan
            //Dels värdet och visa även hur man tar hela objectet 


            int maxShoeSize = personList.Max(p => p.ShoeSize);


           //  when we use First instead of ToList


            var personMaxShoeSize = personList
                                    .OrderByDescending(p => p.ShoeSize)
                                    .First();


            //4.Ta fram de 3 äldsta personerna i listan
            //vi sorterar listan op datum med minsta datumen först . sedan tar vi 
            // 3 första rader
            var oldest = personList
                                    .OrderBy(p => p.BornDate)
                                    .Take(3)
                                    .ToList();



        }
    }
}
