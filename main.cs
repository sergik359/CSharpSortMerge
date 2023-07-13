using System;

class SortMerge {
    const int n = 8;
    
    
    static void Merge(ref int[] A, int p, int q, int r){
        int start = p;
        int final = q + 1;
        int[] mas = new int[n];
        
        for(int i = p; i <= r; i++){
            if((start <= q) && ((final > r) || (A[start] < A[final]))){
                mas[i] = A[start];
                start++;
            }
            else {
                mas[i] = A[final];
                final++;
            }
        }
        
        for(int i = p; i <= r; i++)
            A[i] = mas[i];
    }
    
    
    static void Sort(ref int[] A, int p, int r){
        int q;
        if(p < r ){
            q = (p + r) / 2;
            Sort(ref A, p, q);
            Sort(ref A, q + 1, r);
            Merge(ref A, p, q, r);
        }
    }
    
    
    static void PrintArr(ref int[] A){
        for(int i = 0; i<A.Length; i++)
            Console.Write(A[i] + " ");
        Console.WriteLine();
    }
    
    
    static void Main() {
        int[] A = new int[n] {5,2,4,6,1,3,2,6};
        PrintArr(ref A);
        Sort(ref A, 0, n - 1);
        Console.WriteLine("Упорядоченный массив: ");
        PrintArr(ref A);
    }
}