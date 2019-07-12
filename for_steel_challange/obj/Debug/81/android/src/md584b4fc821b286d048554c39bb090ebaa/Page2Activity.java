package md584b4fc821b286d048554c39bb090ebaa;


public class Page2Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("for_steel_challange.Page2Activity, for_steel_challange", Page2Activity.class, __md_methods);
	}


	public Page2Activity ()
	{
		super ();
		if (getClass () == Page2Activity.class)
			mono.android.TypeManager.Activate ("for_steel_challange.Page2Activity, for_steel_challange", "", this, new java.lang.Object[] {  });
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
