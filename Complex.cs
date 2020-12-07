namespace HomeApp_3 // by Aleksandr K
{
    public class Complex  // Вынес класс в отдельный файл, как и рекомендовали.
    {
        // z=a+bi - выражение вида < - компл число. а - действ, b - мним части.
        // z1 - z2 = (a1 - a2) + (b1 - b2)i;
        // z1 * z2= (a1 + b1i) * (a2 + b2i);

        double re; // Действительная часть
        double im; // Мнимая часть

        public Complex()
        {
            re = 0;
            im = 0;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;  
        }

        public Complex Minus(Complex prm)
        {
            Complex result = new Complex();
            result.re = prm.re - re; // Находим значение действительной части
            result.im = prm.im - im; // Находим значение мнимой части
            return result;
        }

        public Complex Mult(Complex complex2)  
        {
            return new Complex( this.re * complex2.im + this.im * complex2.re, 
                                this.re * complex2.re - this.im * complex2.im );
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }

}
