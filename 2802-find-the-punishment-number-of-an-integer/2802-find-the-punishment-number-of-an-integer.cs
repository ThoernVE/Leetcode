public class Solution {
    public int PunishmentNumber(int n) {
        int result=1;
        for(int i=9; i<=n; i++) {
            int p=i*i;
            if(CanSplitTo(p, i)) result+=p;
        }
        return result;

        static bool CanSplitTo(int p, int i) {
            if(p==i) return true;
            for(int d=10; d<p; d*=10) {
                int q=Math.DivRem(p, d, out int r);
                if(q<=i && CanSplitTo(r, i-q)) return true;
            }
            return false;
        }
    }
}