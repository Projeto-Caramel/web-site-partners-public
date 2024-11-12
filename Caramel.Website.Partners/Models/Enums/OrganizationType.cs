namespace Caramel.Website.Partners.Models.Enums
{
    public enum OrganizationType
    {
        Todos = 0,
        ONG = 1,
        SocialProject = 2,
        Individual = 3
    }

    public static class OrganizationTypeEnumMapper
    {
        public static Dictionary<OrganizationType, string> Mapper = new()
        {
            { OrganizationType.Todos, "Tipo" },
            { OrganizationType.ONG, "Ong" },
            { OrganizationType.SocialProject, "Projeto Social" },
            { OrganizationType.Individual, "Pessoa Física" },
        };
    }
}
