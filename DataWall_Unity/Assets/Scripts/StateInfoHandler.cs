using UnityEngine;

public class StateInfoHandler : MonoBehaviour {

	public GameObject stateInfoWindow;

	public void OnMouseEnter() {
		if (this.stateInfoWindow != null) {
			this.stateInfoWindow.SetActive(true);
		}
	}

	public void OnMouseExit() {
		if (this.stateInfoWindow != null) {
			this.stateInfoWindow.SetActive(false);
		}
	}
}
