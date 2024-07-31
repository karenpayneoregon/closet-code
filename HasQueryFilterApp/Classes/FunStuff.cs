namespace HasQueryFilterApp.Classes;

public class FunStuff
{
    /// <summary>
    /// Mildly shake a form
    /// </summary>
    /// <param name="sender">Form to shake</param>
    public static void Shake(Form sender)
    {
        var original = sender.Location;
        var rnd = new Random(1337);

        const int shakeAmplitude = 20;

        for (int index = 0; index < 15; index++)
        {
                
            sender.Location = new Point(original.X + rnd.Next(-shakeAmplitude, shakeAmplitude), 
                original.Y + rnd.Next(-shakeAmplitude, shakeAmplitude));

            Thread.Sleep(20);
        }

        sender.Location = original;

    }
}