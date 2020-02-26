package md50ffa27ec1fc27d725172843a12ff6a10;


public class UserViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CharterCodingTest.Adapters.UserViewHolder, CharterCodingTest", UserViewHolder.class, __md_methods);
	}


	public UserViewHolder ()
	{
		super ();
		if (getClass () == UserViewHolder.class)
			mono.android.TypeManager.Activate ("CharterCodingTest.Adapters.UserViewHolder, CharterCodingTest", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
