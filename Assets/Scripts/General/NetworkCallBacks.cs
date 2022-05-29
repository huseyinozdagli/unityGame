using Photon.Bolt;
[BoltGlobalBehaviour]
public class NetworkCallbacks : Photon.Bolt.GlobalEventListener
{
    public override void BoltStartBegin()
    {
        BoltNetwork.RegisterTokenClass<Photon.Bolt.PhotonRoomProperties>();
        BoltNetwork.RegisterTokenClass<WeaponDropToken>();
        BoltNetwork.RegisterTokenClass<PlayerToken>();
    }
}
