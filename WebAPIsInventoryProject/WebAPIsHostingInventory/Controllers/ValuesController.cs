namespace WebAPIsHostingInventory.Controllers;


[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet] 
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/values
    [HttpPost]
    public string Post([FromBody]string value)
    {
        return "Creado ahorita";
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public string Put(int id, [FromBody]string value)
    {
        return "Actualizado ahorita";
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Borrado ahorita";
    }
}