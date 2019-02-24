using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_list_serialization_deserialization
{
    [Serializable]
    public class Mark
    {
        public int score;
        
        public Mark() //пустой конструктор
        {

        }

        public Mark (int score)
        {
            this.score = score;
        }

        public string getLetter() //метод, который возврощает букву
        {
            if (score <= 49)
            {
                return "F";
            }
            else if (score >= 50 && score <= 54)
            {
                return "D";
            }
            else if (score >= 55 && score <= 59)
            {
                return "D+";
            }
            else if (score >= 60 && score <= 64)
            {
                return "C-";
            }
            else if (score >= 65 && score <= 69)
            {
                return "C";
            }
            else if (score >= 70 && score <= 74)
            {
                return "C+";
            }
            else if (score >= 75 && score <= 79)
            {
                return "B-";
            }
            else if (score >= 80 && score <= 84)
            {
                return "B";
            }
            else if (score >= 85 && score <= 89)
            {
                return "B+";
            }
            else if (score >= 90 && score <= 94)
            {
                return "A-";
            }
            else
            {
                return "A";
            }
        }

        public override string ToString() //встроенный метод, но мы его изменили по своему
        {
            return score +" "+ getLetter();
        }

    }


}

