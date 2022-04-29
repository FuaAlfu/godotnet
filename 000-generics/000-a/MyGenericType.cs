namespace _000_a
{
public class MyGenericType<T> {
      private T[] array;
      
      public MyGenericType(int size) {
         array = new T[size + 1];
      }
      public T getItem(int index) {
         return array[index];
      }
      public void setItem(int index, T value) {
         array[index] = value;
      }
   }
}