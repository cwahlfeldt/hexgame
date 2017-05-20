using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameGen : MonoBehaviour {

	public Material hexMaterial; //Assigned in inspector
	public Material lineMaterial; //Assigned in inspector

	private void Start() {

		var grid = this.gameObject.AddComponent<Grid>();

		//Set grid settings
		grid.mapShape = MapShape.Hexagon;
		grid.mapWidth = 4;
		grid.mapHeight = 5;
		grid.hexOrientation = HexOrientation.Flat;
		grid.hexRadius = 1;
		grid.hexMaterial = hexMaterial;
		grid.addColliders = true;
		grid.drawOutlines = true;
		grid.lineMaterial = lineMaterial;

		//Gen Grid
		grid.GenerateGrid();

		var tiles = grid.Tiles;
		var i = 0;

		foreach(var tile in tiles) {
			tile.Value.name = "myTile" + i;
			tile.Value.MoveCost = 1;
			tile.Value.gameObject.tag = "Tile";
			var myNeighbors = grid.Neighbours (tile.Value.index)[0];
			Debug.Log (tile.Value.name);
			i++;
		}
	}

	private void PlayerGen () {
		
	}
}
