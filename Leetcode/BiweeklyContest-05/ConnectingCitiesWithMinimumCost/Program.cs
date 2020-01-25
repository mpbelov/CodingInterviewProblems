using System;

namespace ConnectingCitiesWithMinimumCost {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MinimumCost(3, new int[][]{
                new int[]{1,2,5,},
                new int[]{1,3,6,},
                new int[]{2,3,1,},
            }));
        }

        public static int MinimumCost(int N, int[][] connections) {
            var E = new System.Collections.Generic.List<Edge>(N);
            var g = new Graph(N);
            for (int i = 0; i < connections.Length; i++) {
                var e = new Edge {
                    V1 = connections[i][0] - 1,
                    V2 = connections[i][1] - 1,
                    Cost = connections[i][2],
                };
                E.Add(e);
                g.AddEdge(e.V1, e.V2, e.Cost);
            }

            if (!g.IsConnected()) {
                return -1;
            }

            var usedV = new bool[N];
            var notUsedE = new System.Collections.Generic.List<Edge>(E);
            var notUsedV = new System.Collections.Generic.List<int>(N + 1);
            for (int i = 0; i < N; i++) {
                notUsedV.Add(i);
            }
            var MST = new System.Collections.Generic.List<Edge>(N + 1);
            usedV[0] = true; // add vertex 1
            notUsedV.Remove(0);
            while (notUsedV.Count > 0) {
                int minE = -1;
                for (int i = 0; i < notUsedE.Count; i++) {

                    if ((usedV.IndexOf(notUsedE[i].V1) != -1) && (notUsedV.IndexOf(notUsedE[i].V2) != -1) ||
                        (usedV.IndexOf(notUsedE[i].V2) != -1) && (notUsedV.IndexOf(notUsedE[i].V1) != -1)) {
                        if (minE != -1) {
                            if (notUsedE[i].Cost < notUsedE[minE].Cost)
                                minE = i;
                        }
                        else
                            minE = i;
                    }
                }

                if (usedV.IndexOf(notUsedE[minE].V1) != -1) {
                    usedV.Add(notUsedE[minE].V2);
                    notUsedV.Remove(notUsedE[minE].V2);
                }
                else {
                    usedV.Add(notUsedE[minE].V1);
                    notUsedV.Remove(notUsedE[minE].V1);
                }

                MST.Add(notUsedE[minE]);
                notUsedE.RemoveAt(minE);
            }

            var sum = 0;
            foreach (var e in MST) {
                sum += e.Cost;
            }
            return sum;
        }

        class Edge {
            public int V1 { get; set; }
            public int V2 { get; set; }
            public int Cost { get; set; }
        }

        class Graph {
            public Graph(int N) {
                adjacentList = new System.Collections.Generic.LinkedList<int>[N];
                weights = new int[N, N];
                for (int i = 0; i < N; i++) {
                    adjacentList[i] = new System.Collections.Generic.LinkedList<int>();
                }
            }
            private System.Collections.Generic.LinkedList<int>[] adjacentList;
            private int[,] weights;

            public void AddEdge(int v1, int v2, int weight) {
                adjacentList[v1].AddFirst(v2);
                adjacentList[v2].AddFirst(v1);
                weights[v1, v2] = weight;
                weights[v2, v1] = weight;
            }

            public System.Collections.Generic.IEnumerable<int> GetAdjacent(int v) {
                return adjacentList[v];
            }

            public int MSTTotalWeight() {
                var frontier = new System.Collections.Generic.List<int>();
                var visited = new bool[adjacentList.Length];
                frontier.Add(0);
                visited[0] = true;

                while (frontier.Count < adjacentList.Length) {
                    var adj = GetAdjacent(frontier[frontier.Count - 1]);
                    foreach (var a in adj) {
                        if (visited[a]) {
                            continue;
                        }
                    }
                }
            }

            private bool[] visited;
            private int count;
            public bool IsConnected() {
                visited = new bool[adjacentList.Length];
                count = 0;
                dfs(1);
                return count + 1 == adjacentList.Length;
            }
            private void dfs(int v) {
                visited[v] = true;
                count++;

                foreach (var adj in GetAdjacent(v)) {
                    if (!visited[adj]) {
                        dfs(adj);
                    }
                }
            }
        }
    }
}
