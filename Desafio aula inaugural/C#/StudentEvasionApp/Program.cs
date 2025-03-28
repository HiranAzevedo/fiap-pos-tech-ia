//Load sample data
using StudentEvasionApp;

var sampleData = new StudentEvasionModel.ModelInput()
{
    Marital_status = 10F,
    Application_mode = 6F,
    Application_order = 1F,
    Course = 110F,
    Daytime_evening_attendance = 1F,
    Previous_qualification = 1F,
    Nacionality = 1F,
    Mother_s_qualification = 10F,
    Father_s_qualification = 30F,
    Mother_s_occupation = 4F,
    Father_s_occupation = 4F,
    Displaced = 1F,
    Educational_special_needs = 0F,
    Debtor = 0F,
    Tuition_fees_up_to_date = 0F,
    Gender = 1F,
    Scholarship_holder = 0F,
    Age_at_enrollment = 19F,
    International = 0F,
    Curricular_units_1st_sem__credited_ = 0F,
    Curricular_units_1st_sem__enrolled_ = 6F,
    Curricular_units_1st_sem__evaluations_ = 6F,
    Curricular_units_1st_sem__approved_ = 6F,
    Curricular_units_1st_sem__grade_ = 140F,
    Curricular_units_1st_sem__without_evaluations_ = 0F,
    Curricular_units_2nd_sem__credited_ = 0F,
    Curricular_units_2nd_sem__enrolled_ = 6F,
    Curricular_units_2nd_sem__evaluations_ = 6F,
    Curricular_units_2nd_sem__approved_ = 6F,
    Curricular_units_2nd_sem__grade_ = 1.3666666E+16F,
    Curricular_units_2nd_sem__without_evaluations_ = 0F,
    Unemployment_rate = 139F,
    Inflation_rate = -3F,
    GDP = 79F,
};

//Load model and predict output
var result = StudentEvasionModel.Predict(sampleData);

Console.WriteLine($"Text: {sampleData.Course}\n Predict: {result.PredictedLabel}");