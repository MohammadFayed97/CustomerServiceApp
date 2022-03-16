namespace AppSquare.Shared.Client;

public static class JwtParser
{
    public static IEnumerable<Claim> ExtractClaimsFromJwt(string jwt)
    {
        List<Claim> claims = new List<Claim>();
        string payload = jwt.Split(".")[1];

        byte[] jsonBytes = ParseBase64WithoutPadding(payload);

        Dictionary<string, object> KeyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        claims.AddRange(KeyValuePairs.Select(e => new Claim(e.Key, e.Value.ToString())));

        return claims;
    }
    private static byte[] ParseBase64WithoutPadding(string base64)
    {
        switch (base64.Length % 4)
        {
            case 2: base64 += "==";
                break;
            case 3: base64 += "=";
                break;
        }
        return Convert.FromBase64String(base64);
    }
}
