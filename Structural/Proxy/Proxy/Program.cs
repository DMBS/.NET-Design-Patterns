namespace Proxy
{
    /*
        The proxy pattern is used to provide access to an object. 
        It is often used to enable this access over some distance - 
        this could be providing remote access, 
        or adding an extra level of protection around the object. 
        The crucial thing is that the proxy pattern offers a way 
        to indirectly provide (and control) access. 
        It is similar in implementation to the decorator pattern, 
        but its purpose is different. 
        Both patterns wrap an inner object, 
        however the decorator pattern expands on the functionality 
        of the inner object, where the proxy pattern 
        instead governs the access to the object.
        
        The proxy pattern can be used to restrict access to an object, 
        to provide a simpler or lightweight interface, 
        or to allow the client to communicate with a remote 
        object via a local representation.
        
     */
    class Program
    {
        static void Main(string[] args)
        {
            var secureNestProxy = new SecureNestProxy(new RealNest());

            secureNestProxy.Access("Stegosaurus");
            secureNestProxy.Access("TRex");
        }
    }
}
