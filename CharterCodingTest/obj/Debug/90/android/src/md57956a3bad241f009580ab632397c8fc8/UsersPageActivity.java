package md57956a3bad241f009580ab632397c8fc8;


public class UsersPageActivity
	extends md58d25d7d36a89bfc21ba32bca6da1d4fb.ActivityBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CharterCodingTest.Activities.UsersPageActivity, CharterCodingTest", UsersPageActivity.class, __md_methods);
	}


	public UsersPageActivity ()
	{
		super ();
		if (getClass () == UsersPageActivity.class)
			mono.android.TypeManager.Activate ("CharterCodingTest.Activities.UsersPageActivity, CharterCodingTest", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
