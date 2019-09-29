using UnityEngine;

public struct NickName
{
    public string name;

    public static NickName FromJson(string msg)
    {
        return JsonUtility.FromJson<NickName>(msg);
    }
}

public struct Coord
{
    public int x;
    public int y;

    public Coord(Vector3 coord)
    {
        x = (int)coord.x;
        y = (int)coord.y;
    }

    public static Coord FromJson(string msg)
    {
        return JsonUtility.FromJson<Coord>(msg);
    }

    public static implicit operator Coord(Vector2 coord)
    {
        return new Coord { x = (int)coord.x, y = (int)coord.y };
    }

    public static implicit operator Vector2(Coord coord)
    {
        return new Vector2(coord.x, coord.y);
    }
}

public struct StartValues
{
    public int x;
    public int y;
    public int size;

    public static StartValues FromJson(string msg)
    {
        return JsonUtility.FromJson<StartValues>(msg);
    }
}

public struct Size
{
    public int size;

    public static Size FromJson(string msg)
    {
        return JsonUtility.FromJson<Size>(msg);
    }
}

public struct PlayerInfo
{
    public string id;

    public int name;
    public Vector2Int coord;
    public int size;

    public static PlayerInfo FromJson(string msg)
    {
        return JsonUtility.FromJson<PlayerInfo>(msg);
    }
}