public class Solution {

    public string Encode(IList<string> strs) {
        if ( strs == null || strs.Count == 0) 
            return string.Empty;

        var sb = new StringBuilder();

        foreach (var str in strs) {
            var strLen = str.Length;
            sb.Append($"{strLen}#{str}");
        }
        return sb.ToString().Trim();
    }

    public List<string> Decode(string s) {
        var decodedStrs = new List<string>();

        var i = 0;
        var j = 0;

        while(i < s.Length) {
            j = i;
            while(s[j] != '#') j++;
            var len = int.Parse(s.Substring(i, j - i));
            var word = s.Substring(j + 1, len);
            decodedStrs.Add(word);
            i = j + 1 + len;
        }
        return decodedStrs;
    }
}
