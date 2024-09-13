using Microsoft.AspNetCore.Components;

namespace TreeDemo.Pages
{
    public partial class Home: ComponentBase
    {
        private List<NodeType> soruces = new List<NodeType>();
        protected override Task OnInitializedAsync()
        {
            soruces = new()
            {
                new NodeType()
                {
                    Name="root",
                    Id=0,
                    ParentId=1000,
                },
                new NodeType()
                {
                    Name="c1",
                    Id=1,
                    ParentId=0,
                },
                new NodeType()
                {
                    Name="root",
                    Id=2,
                    ParentId=0,
                },
                new NodeType()
                {
                    Name="root",
                    Id=3,
                    ParentId=1,
                }

            };
            return base.OnInitializedAsync();
        }

        private void SelectNode()
        { }

        private void OnDblClick()
        { }
    }

    public class NodeType
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int ParentId { get; set; }
    }
}
