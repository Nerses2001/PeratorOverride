
namespace PeratorOverride
{
    internal class Digit
    {
        public byte value;

        public Digit(byte value)
        {
            this.value = value;
        }

        /*public static explicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }*/
        public static implicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString() => this.value.ToString();


    }
}
