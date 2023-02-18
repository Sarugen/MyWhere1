using System.Linq;

var list = new List<int> { 1, 2, 3, 4 };

var oddQuery = list.Select(Filter); // MyWhere - ваш метод
bool Filter (int i)
{ 
    return i % 2 != 0;
}

list.Add(5);

var filterredList = oddQuery.ToList(); // 1, 3, 5


/*var list = new List<int> { 1, 2, 3, 4 };

var oddQuery = list.Where(i => i % 2 != 0);

    
    

list.Add(5);
var filterredList = oddQuery.ToList(); // 1, 3, 5
*/