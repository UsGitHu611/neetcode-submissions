public class ListNode {
    public int _val;
    public ListNode _next;
    
    public ListNode(int val) {
        _val = val;
        _next = null;
    }

    public ListNode(int val, ListNode next) {
        _val = val;
        _next = next;
    }
}

public class LinkedList {
    private ListNode _head;
    private ListNode _tail;

    public LinkedList() {
        _head = new ListNode(-1);
        _tail = _head;
    }

    public int Get(int index) {
        ListNode curr = _head._next;
        int i = 0;
        while (curr != null) {
            if (i == index) return curr._val;
            i++;
            curr = curr._next;
        }
        return -1;
    }

    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);
        newNode._next = _head._next;
        _head._next = newNode;
        if (newNode._next == null) _tail = newNode;
    }

    public void InsertTail(int val) {
        _tail._next = new ListNode(val);
        _tail = _tail._next;
    }

    public bool Remove(int index) {
        int i = 0;
        ListNode curr = _head;

        while (i < index && curr != null) {
            curr = curr._next;
            i++;
        }

        if (curr != null && curr._next != null) {
            if (curr._next == _tail) _tail = curr;
            curr._next = curr._next._next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() {
        List<int> res = new List<int>();
        ListNode curr = this._head._next;
        while (curr != null) {
            res.Add(curr._val);
            curr = curr._next;
        }
        return res;
    }
}