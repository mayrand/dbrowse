using System.Text.Json;
using dbrowseModels;

namespace HardkorowyKodsu;

public partial class Form1 : Form
{
    private readonly string dbrowseapi_HostAddress = ConfigHelper.GetApiHostname();
    private readonly HttpClient _httpClient;

    public Form1()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        this.Load += FetchDataAsync;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
    }

    private async void FetchDataAsync(object sender, EventArgs e)
    {
        try
        {
            var response = await _httpClient.GetAsync(dbrowseapi_HostAddress + "/InformationSchemaTables");
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<InformationSchema[]>(responseData);

            listView1.Items.Clear();
            foreach (var table in data)
            {
                listView1.Items.Add($"{table.name}, Type: {table.type}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0) return;
        try
        {
            var tableInfo = listView1.SelectedItems[0].Text;
            var table = tableInfo.Substring(0, tableInfo.IndexOf(','));
            var response = await _httpClient.GetAsync(dbrowseapi_HostAddress + "/InformationSchemaColumns/" + table);
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<string[]>(responseData);

            listView2.Items.Clear();
            foreach (var column in data)
            {
                listView2.Items.Add(column);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}