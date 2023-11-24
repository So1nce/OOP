public class Flower
{
    public static int PetalsCount = 7;

    public void GenerateEvent()
    {
        if (PetalsCount > 0)
        {
            if (PetalsCount > 1)
            {
                PetalsCount--;
                Event1?.Invoke();
            }
            else
            {
                PetalsCount--;
                Event2?.Invoke();
            }
        }
    }

    public static event Action Event1;
    public static event Action Event2;
}