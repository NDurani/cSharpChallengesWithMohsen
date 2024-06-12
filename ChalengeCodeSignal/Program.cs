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
}
