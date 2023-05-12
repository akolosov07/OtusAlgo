using OtusDemoucron;

int[] list1A = new int[8] { 0, 1, 0, 0, 0, 0, 0, 0 };
int[] list2A = new int[8] { 0, 0, 0, 0, 1, 0, 0, 0 };
int[] list3C = new int[8] { 0, 0, 0, 1, 0, 0, 0, 0 };
int[] list4D = new int[8] { 1, 1, 0, 0, 1, 1, 0, 0 };
int[] list5E = new int[8] { 0, 0, 0, 0, 0, 0, 1, 0 };
int[] list6F = new int[8] { 0, 0, 0, 0, 0, 0, 0, 1 };
int[] list7G = new int[8] { 0, 0, 0, 0, 0, 0, 0, 1 };
int[] list8H = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

int[][] graph = new int[][]
    {
        list1A, list2A, list3C, list4D, list5E, list6F, list7G, list8H
    };


DemoucronAlgorithm demoucronAlgorithm = new DemoucronAlgorithm();
var vertexList = demoucronAlgorithm.GetLevels(graph);





