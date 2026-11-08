public class MinStack {
    private int[] Stack;
    private int SizeStack;
    private int Min_value;

    public MinStack() {
        SizeStack = 0;
        Stack = new int[SizeStack];
        Min_value = int.MaxValue;
    }

    public void Push(int val) {
        int OldSizeStack = SizeStack;
        if (SizeStack < int.MaxValue) {
            SizeStack++;
        }
        int[] NewStack = new int[SizeStack];

        if (OldSizeStack > 0) {
            Array.Copy(Stack, NewStack, OldSizeStack);
        }
        NewStack[OldSizeStack] = val;
        Stack = NewStack;
        Min_value = Math.Min(Min_value, val);
    }

    public void Pop() {
        if (SizeStack == 0) return;
        int OldSizeStack = SizeStack;
        SizeStack--;
        int[] NewStack = new int[SizeStack];

        if (SizeStack > 0) {
            Array.Copy(Stack, NewStack, SizeStack);
        }
        Stack = NewStack;
        Min_value = int.MaxValue;
        for (int i = 0; i < SizeStack; i++) {
            Min_value = Math.Min(Min_value, Stack[i]);
        }
    }

    public int Top() {
        if (SizeStack == 0) throw new InvalidOperationException("Stack is empty");
        return Stack[SizeStack - 1];
    }

    public int GetMin() {
        return Min_value;
    }
}
