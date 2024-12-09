namespace Day1;

internal class SolvingTask
{
    private readonly string[] _data;

    public SolvingTask(string[] data)
    {
        _data = data;
    }

    public (int totalDistance, int similarityScore)? Task()
    {
        var (leftList, rightList) = ParseLists(_data);

        if (leftList.Count != rightList.Count)
            return null;

        var totalDistance = CalculateTotalDistance(leftList, rightList);
        var similarityScore = CalculateSimilarityScore(leftList, rightList);

        return (totalDistance, similarityScore);
    }

    private (List<int> leftList, List<int> tightList) ParseLists(string[] data)
    {
        List<int> leftList = new();
        List<int> rightList = new();

        foreach (var item in _data)
        {
            var split = item.Split("  ");
            if (split is null)
                continue;
            if (int.TryParse(split[0], out int leftValue))
                leftList.Add(leftValue);
            if (int.TryParse(split[1], out int rightValue))
                rightList.Add(rightValue);
        }

        return (leftList, rightList);
    }

    private int CalculateTotalDistance(List<int> leftList, List<int> rightList)
    {
        leftList.Sort();
        rightList.Sort();

        var totalDistance = 0;
        for (int i = 0; i < leftList.Count; i++)
            totalDistance += Math.Abs(leftList[i] - rightList[i]);

        return totalDistance;
    }

    private int CalculateSimilarityScore(List<int> leftList, List<int> rightList)
    {
        var rightCountDict = rightList.GroupBy(x => x)
            .ToDictionary(x => x.Key, y => y.Count());

        return leftList.Sum(x => x * (rightCountDict.ContainsKey(x) ? rightCountDict[x] : 0));
    }
}
