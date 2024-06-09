int polygramOuterArea(int n) {
    if(n == 1){
        return 1;
    }else{
        return (int)(Math.Pow(n, 2) + Math.Pow((n-1), 2));
    }
}
