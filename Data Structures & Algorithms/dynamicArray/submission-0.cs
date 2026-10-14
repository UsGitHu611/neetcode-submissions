public class DynamicArray {
    private int[] _array;
    private int _capacity;
    private int _length;

    public DynamicArray(int capacity) {
        _capacity = capacity;
        _length = 0;
        _array = new int[_capacity];
    }

    public int Get(int i) {
        return _array[i];
    }

    public void Set(int i, int n) {
        _array[i] = n;
    }

    public void PushBack(int n) {
        if (_length == _capacity) Resize();
        _array[_length] = n;
        _length++;
    }

    public int PopBack() {
        if (_length > 0) _length--;
        return _array[_length];
    }

    private void Resize() {
        _capacity *= 2;
        int[] temp_array = new int[_capacity];
        for (int i = 0; i < _length; i++)
            temp_array[i] = _array[i];
        _array = temp_array;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
