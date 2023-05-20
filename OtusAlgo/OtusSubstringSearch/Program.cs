using OtusSubstringSearch;

//SearchString searchString = new SearchString();
//string text = "STRONGSIRING";
//string mask = "RING";
//int res = searchString.SearchFullScan(text, mask);
//Console.WriteLine(res);

SearchString searchString = new SearchString();
string text = "STRONGSIRING";
string mask = "RING";
int res = searchString.SearchBMH(text, mask);
Console.WriteLine(res);