namespace A7Console
{
    public class Test
    {
        public int[] secondArray = {69, 420};

        public int[] MethodBeingCalled(int[] array)
        {
            secondArray = array;
            secondArray[0] = 68;
            return secondArray;
        }
    }
}