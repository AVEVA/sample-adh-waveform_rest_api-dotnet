namespace SdsRestApiCore
{
    public class Role
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RoleScope { get; set; }

        public string TenantId { get; set; }

        public string CommunityId { get; set; }

        public string RoleTypeId { get; set; }
    }
}
