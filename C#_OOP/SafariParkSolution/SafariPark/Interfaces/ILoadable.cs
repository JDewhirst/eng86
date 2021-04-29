namespace SafariPark
{
    interface ILoadable
    {
        int Capacity { get; set; }
        int Ammunition { get; set; }

        abstract void Reload();
    }
}
