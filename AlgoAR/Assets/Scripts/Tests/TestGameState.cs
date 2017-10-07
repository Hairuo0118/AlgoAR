//using UnityEngine;
//using UnityEditor;
//using UnityEngine.TestTools;
//using NUnit.Framework;
//using System.Collections;
//
//public class NewEditModeTest {
//
//
//	/**
//	 * Testing Strategy:
//	 * number of elements: 0,1,>1
//	 * where to insert: at the front, in the middle, at the end
//	 */
//
//	// I haven't included some key process yet
//	// Will do whem the detailed input/output is decided
//
//	public static readonly Marker sorted0 = new Marker(); 
//	public static readonly Marker sorted1 = new Marker();
//	public static readonly Marker sorted2 = new Marker();
//	public static readonly Marker sorted3 = new Marker();
//	public static readonly Marker queuedSmall = new Marker ();
//	public static readonly Marker queuedLarge = new Marker ();
//	public static readonly Marker queuedMedium = new Marker();
//
//	public static readonly List<Marker> sampleMarkers = new ArrayList<Marker>();
//
//	public static bool CompareOrders(List<Marker> expected, List<Marker> existing){
//		if (expected.size () != existing.size ())
//			return false;
//		for (int i = 0; i < expected.size (); i++) {
//			if (expected.get (i) != existing.get (i)) {
//				return false;
//			}
//		}
//		return true;
//	}
//
//	[Test]
//	// test empty
//	public void TestEmpty(){
//		List<Marker> emptyList = new List<Marker> ();
//		Assert.True (nextMove (emptyList).size () == 0);
//	}
//
//	[Test]
//	// test one element
//	public void TestOneElement(){
//		
//	}
//
//	[Test]
//	// test last item should go to the far left 
//	public void TestGoToFarLeft(){
//		
//	}
//
//	[Test]
//	// Don't need to swap
//	public void TestDontNeedSwap(){
//		
//	}
//
//	[Test]
//	// In the middle of something
//	public void TestInTheMiddle(){
//		
//	}
//
//}
