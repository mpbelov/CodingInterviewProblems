using System.Collections.Generic;

namespace AdventOfCode10 {
    public class Graph {
        public Graph() {
            _adjacentList = new Dictionary<string, LinkedList<string>>();
        }

        private Dictionary<string, LinkedList<string>> _adjacentList;

        public void AddVertex(string vertex) {
            if (!_adjacentList.ContainsKey(vertex)) {
                _adjacentList.Add(vertex, new LinkedList<string>());
            }
        }

        public void AddEdge(string v1, string v2) {
            AddVertex(v1);
            AddVertex(v2);
            _adjacentList[v1].AddFirst(v2);
            _adjacentList[v2].AddFirst(v1);
        }

        public IReadOnlyCollection<string> GetAdjacent(string vertex) {
            if (!_adjacentList.TryGetValue(vertex, out LinkedList<string> list)) {
                throw new KeyNotFoundException(vertex);
            }
            return list;
        }

        public IReadOnlyCollection<string> GetVertexes() {
            return _adjacentList.Keys;
        }
    }

    public class ConnectedComponents {
        public ConnectedComponents(Graph graph) {
            _graph = graph;
        }

        private Graph _graph;

        public IReadOnlyCollection<IReadOnlyCollection<string>> Build() {
            var visited = new HashSet<string>();
            var frontier = new Queue<string>();
            var ccs = new List<List<string>>();

            foreach (var v in _graph.GetVertexes()) {
                if (visited.Contains(v)) {
                    continue;
                }
                var cc = new List<string>();
                visited.Add(v);
                frontier.Enqueue(v);
                while (frontier.Count > 0) {
                    var currentVertex = frontier.Dequeue();
                    cc.Add(currentVertex);
                    foreach (var adj in _graph.GetAdjacent(currentVertex)) {
                        if (!visited.Contains(adj)) {
                            visited.Add(adj);
                            frontier.Enqueue(adj);
                        }
                    }
                }
                ccs.Add(cc);
            }

            return ccs;
        }
    }
}