int polygramOuterArea(int n) {
    if(n == 1){
        return 1;
    }else{
        return (int)(Math.Pow(n, 2) + Math.Pow((n-1), 2));
    }
}
int MakeArrayConsecutive(int[] statues) {
    int mx = statues.Max();
    int mn = statues.Min();
    int result = 0;
    for(int i =mn; i<mx; i++){
        if(!statues.Contains(i)){
        result+=1;
        }
    }return result;

//sorting list and People

int[] solution(int[] a) {
int[] result = new int[a.Length];
List<int> sorted_list = new List<int>{};
for(int i = 0; i<a.Length; i++){
    if(a[i] == -1){
        result[i] = -1;
    }
    else{
        sorted_list.Add(a[i]);
    }
}
sorted_list.Sort();
int counter = 0;
for(int i = 0; i<result.Length;i++){
    if(result[i] == -1){
        result[i] = -1;
    }else{
        result[i] = sorted_list[counter];
        counter++;
    }
}return result;
}

}
