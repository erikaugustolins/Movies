namespace BackSharp.Models
{
    public class Filme
    {
        private int id;
        private string name;
        private string title;
        private string year;
        private string debut;
        private string recipe;

       public int getID() 
        {
            return this.id;
        }

       public string getName() 
        {
            return this.name;
        }

       public void setName(string name) 
        {
            this.name = name;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title) 
        {
            this.title = title;
        }

        public string getYear()
        {
            return this.year;
        }

        public void setYear(string year)
        {
            this.year = year;
        }

        public string getDebut()
        {
            return this.debut;
        }

        public void setDebut(string debut)
        {
            this.debut = debut;
        }

        public string getRecipe()
        {
            return this.recipe;
        }

        public void setRecipe(string recipe)
        {
            this.recipe = recipe;
        }




    }
}
