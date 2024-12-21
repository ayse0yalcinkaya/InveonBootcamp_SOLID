using System.Threading.Channels;

//birinde var birinde yoksa abstract yapıp hata fırlatmak yerine onu aynı interface yap

namespace InveonBootcamp2.App.LSP
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }


    public abstract class Phone
    {
        public void Call()
        {
            Console.WriteLine("phone call");
        }

        //public abstract void TakePhoto();
    }

    public class Iphone: Phone, ITakePhoto 
    {
        public void FaceTime()
        {
            Console.WriteLine("iphone facetime");
        }

        //public override void TakePhoto()
        //{
        //    Console.WriteLine("Iphone take photo");
        //}

        public void TakePhoto()
        {
            Console.WriteLine("iphone take photo");
        }
    }

    public class Nokia: Phone
    {
        //public override void TakePhoto()
        //{
        //    throw new NotImplementedException();
        //} 

    }
}
