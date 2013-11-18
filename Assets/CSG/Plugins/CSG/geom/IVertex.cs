namespace CSG {

using UnityEngine;

public interface IVertex {
    Vector3 pos {get; set;}
    IVertex clone();
    void flip();
    IVertex interpolate(IVertex other, float t);
}

}