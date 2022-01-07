namespace MyQueue;
public class Fila
{

    Nodo? cur;

    public void StackUp(object newObj)
    {
        if (this.cur == null)
        {
            this.cur = new Nodo(null, newObj);

        }
        else
        {
            if (this.cur.next == null)
            {
                Nodo current = new Nodo(this.cur, newObj);
                this.cur.next = current;
                this.cur = current;
            }
            else
            {
                Nodo current = new Nodo(this.cur.next, newObj);
                this.cur.next = current;
                this.cur = current;
            }
        }
    }

    public object Unstack()
    {
        if (this.cur != null)
        {
            if (this.cur.next != null)
            {
                if (this.cur == this.cur.next.next)
                {
                    object obj1 = this.cur.next.obj;
                    this.cur.next = null;
                    return obj1;
                }
                else
                {
                    Nodo first = this.cur.next;
                    this.cur.next = first.next;
                    return first.obj;
                }
            }else
            {
                object obj1 = this.cur.obj;
                this.cur = null;
                return obj1;
            }
        }
        else
        {
            throw new ArgumentException("Empty Stack!");
        }
    }


    public void print()
    {
        
        if (this.cur != null)
        {
            string toPrint = "";
            if(this.cur.next == null)
            {
                toPrint += this.cur.obj;
            }else{
                Nodo current = this.cur.next;
                while(current != this.cur)
                {
                    toPrint += current.obj +" -> ";
                    current = current.next;
                }
                toPrint+= this.cur.obj;
            }

            Console.WriteLine(toPrint);
        }else
        {
            Console.WriteLine("Empty Queue/Fila vazia");
        }
    }
    public class Nodo
    {
        public Nodo next { get; set; }
        public object obj { get; set; }
        public Nodo(Nodo next, object obj)
        {
            this.next = next;
            this.obj = obj;
        }
    }

}
